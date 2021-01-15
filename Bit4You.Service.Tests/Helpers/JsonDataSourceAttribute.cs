using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bit4You.Service.Tests.Helpers
{
    public class JsonDataSourceAttribute : Attribute, ITestDataSource
    {
        public string FilePath { get; set; }

        public IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            if (string.IsNullOrWhiteSpace(FilePath))
                throw new ArgumentNullException("FilePath cannot be empty.");

            if (!File.Exists(FilePath))
                throw new ArgumentException($"{FilePath} does not exists.");

            var json = File.ReadAllText(FilePath);
            yield return new object[] { json };
        }

        public string GetDisplayName(MethodInfo methodInfo, object[] data)
        {
            if (data != null)
                return $"Test - { methodInfo.Name} ({FilePath})";

            return null;
        }
    }
}
