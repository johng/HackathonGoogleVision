using System;
using System.Collections.Generic;
using Google.Cloud.Vision.V1;

namespace Visual
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            // Instantiates a client
            var client = ImageAnnotatorClient.Create();
            // Load the image file into memory
            var image = Image.FromFile("funny.jpg");
            // Performs label detection on the image file
            var response = client.DetectText(image);
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    Console.WriteLine(annotation.Description);
            }
        }
    }
}