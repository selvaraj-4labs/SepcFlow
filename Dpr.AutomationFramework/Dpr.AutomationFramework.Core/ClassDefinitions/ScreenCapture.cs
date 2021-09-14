using Dpr.AutomationFramework.Dpr.AutomationFramework.Savings.DSL.StepDefinition;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class ScreenCapture
    {
        public string Capture(IWebDriver driver, string fileName = null)
        {
   
            if (fileName == null)
            {
                fileName = "Screenshot";
            }
            string saveFilePath = @"C:\agent-work\_temp\TestResults\" + 
                fileName + DateTime.Now.ToString("yyyyMMddHHmmssfff") +
                ".jpg";
            Image screenshotImage = GetWholeWebScreenshot(driver);
            screenshotImage.Save(saveFilePath);

            return Path.GetFullPath(saveFilePath);
        }

        private Image GetWholeWebScreenshot(IWebDriver driver)
        {
            // Get total dimensions of webpage
            int totalWidth = (int)(long)((IJavaScriptExecutor)driver).ExecuteScript("return document.body.offsetWidth");
            int totalHeight = (int)(long)((IJavaScriptExecutor)driver).ExecuteScript("return document.body.parentNode.scrollHeight");

            // Get dimensions of the open web browser
            var viewportWidth = (int)(long)((IJavaScriptExecutor)driver).ExecuteScript("return document.body.clientWidth");
            var viewportHeight = (int)(long)((IJavaScriptExecutor)driver).ExecuteScript("return window.innerHeight");

            // Scroll to the top of the webpage
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, 0)");

            // If the entire webpage fits in the webpage take a single screenie
            if (totalWidth <= viewportWidth &&
                totalHeight <= viewportHeight)
            {
                Screenshot screenie = ((ITakesScreenshot)driver).GetScreenshot();
                return ScreenshotToImage(screenie);
            }
            List<Rectangle> rectangles = new List<Rectangle>();
            for(int y = 0; y < totalHeight; y += viewportHeight)
            {
                int newHeight = viewportHeight;
                // Fix if the height of the element is too big
                if (y + viewportHeight > totalHeight)
                {
                    newHeight = totalHeight - y;
                }
                for (int x = 0; x < totalWidth; x += viewportWidth)
                {
                    int newWidth = viewportWidth;
                    if (x + viewportWidth > totalWidth)
                    {
                        newHeight = totalWidth - x;
                    }

                    Rectangle currentRectangle = new Rectangle(x, y, newWidth, newHeight);
                    rectangles.Add(currentRectangle);
                }
            }

            Bitmap stitchedImage = new Bitmap(totalWidth, totalHeight);
            
            // Stitch all screenies together
            Rectangle previous = Rectangle.Empty;
            foreach (Rectangle rectangle in rectangles)
            {
                if (previous != Rectangle.Empty)
                {
                    int dx = rectangle.Right - previous.Right;
                    int dy = rectangle.Bottom - previous.Bottom;
                    ((IJavaScriptExecutor)driver).ExecuteScript(String.Format("window.scrollBy({0}, {1})", dx, dy));
                }
                // Take screenie
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                // Build image from screenie
                Image screenshotImage = ScreenshotToImage(ss);
                // Calculate the source rectangle
                Rectangle sourceRectangle = new Rectangle(
                    viewportWidth - rectangle.Width, 
                    viewportHeight - rectangle.Height, 
                    rectangle.Width, 
                    rectangle.Height);
                // Copy the image
                using (var graphics = Graphics.FromImage(stitchedImage))
                {
                    graphics.DrawImage(screenshotImage, rectangle, sourceRectangle, GraphicsUnit.Pixel);
                }
                // Update the previous rectangle
                previous = rectangle;
            }
            return stitchedImage;
        }

        private static Image ScreenshotToImage(Screenshot screenshot)
        {
            Image screenshotImage;
            using (var memStream = new MemoryStream(screenshot.AsByteArray))
            {
                screenshotImage = Image.FromStream(memStream);
            }
            return screenshotImage;
        }

        public string Capture(WindowsDriver<WindowsElement> driver, string fileName = null)
        {
            if (fileName == null)
            {
                fileName = "Screenshot";
            }
            string saveFilePath = @"C:\agent-work\_temp\TestResults\" + 
                fileName + DateTime.Now.ToString("yyyyMMddHHmmssfff") +
                ".jpg";
            Screenshot ss = driver.GetScreenshot();
            ss.SaveAsFile(saveFilePath, ScreenshotImageFormat.Jpeg);

            return Path.GetFullPath(saveFilePath);
            //return saveFilePath;
        }
    }
}
