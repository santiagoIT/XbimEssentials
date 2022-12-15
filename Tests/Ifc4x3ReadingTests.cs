﻿using FluentAssertions;
using Microsoft.Extensions.Logging;
using Serilog;
using System.IO;
using Xbim.Common;
using Xbim.Ifc;
using Xbim.Ifc4x3;
using Xbim.IO.Memory;
using Xunit;

namespace Xbim.Essentials.Tests
{
    public class Ifc4x3ReadingTests
    {
        [Theory]
        [InlineData(@"TestFiles\IFC4x3\DirectrixDerivedReferenceSweptAreaSolid-1.ifc")]
        [InlineData(@"TestFiles\IFC4x3\DirectrixDerivedReferenceSweptAreaSolid-2.ifc")]
        [InlineData(@"TestFiles\IFC4x3\FixedReferenceSweptAreaSolid-1.ifc")]
        [InlineData(@"TestFiles\IFC4x3\Header example.ifc")]
        [InlineData(@"TestFiles\IFC4x3\SectionedSolidHorizontal-1.ifc")]
        [InlineData(@"TestFiles\IFC4x3\SectionedSolidHorizontal-2.ifc")]
        [InlineData(@"TestFiles\IFC4x3\SectionedSolidHorizontal-3.ifc")]
        [InlineData(@"TestFiles\IFC4x3\SectionedSolidHorizontal-4.ifc")]
        [InlineData(@"TestFiles\IFC4x3\SectionedSolidHorizontal-5.ifc")]
        [InlineData(@"TestFiles\IFC4x3\SectionedSolidHorizontal-6.ifc")]
        [InlineData(@"TestFiles\IFC4x3\test0.ifc")]
        [InlineData(@"TestFiles\IFC4x3\test1.ifc")]
        [InlineData(@"TestFiles\IFC4x3\test2.ifc")]
        public void CanParseSampleFiles(string file)
        {
            var config = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.Debug()
                .CreateLogger();
            var logger = (new LoggerFactory()).AddSerilog(config).CreateLogger(typeof(IModel));

            using var stream = File.OpenRead(file);
            var model = new MemoryModel(new EntityFactoryIfc4x3Add1(), logger)
            {
                AllowMissingReferences = false
            };

            var errors = model.LoadStep21(stream, stream.Length);
            errors.Should().Be(0, "There should be no errors.");
        }

        [Theory]
        [InlineData(@"TestFiles\IFC4x3\DirectrixDerivedReferenceSweptAreaSolid-1.ifc")]
        [InlineData(@"TestFiles\IFC4x3\DirectrixDerivedReferenceSweptAreaSolid-2.ifc")]
        [InlineData(@"TestFiles\IFC4x3\FixedReferenceSweptAreaSolid-1.ifc")]
        [InlineData(@"TestFiles\IFC4x3\Header example.ifc")]
        [InlineData(@"TestFiles\IFC4x3\SectionedSolidHorizontal-1.ifc")]
        [InlineData(@"TestFiles\IFC4x3\SectionedSolidHorizontal-2.ifc")]
        [InlineData(@"TestFiles\IFC4x3\SectionedSolidHorizontal-3.ifc")]
        [InlineData(@"TestFiles\IFC4x3\SectionedSolidHorizontal-4.ifc")]
        [InlineData(@"TestFiles\IFC4x3\SectionedSolidHorizontal-5.ifc")]
        [InlineData(@"TestFiles\IFC4x3\SectionedSolidHorizontal-6.ifc")]
        [InlineData(@"TestFiles\IFC4x3\test0.ifc")]
        [InlineData(@"TestFiles\IFC4x3\test1.ifc")]
        [InlineData(@"TestFiles\IFC4x3\test2.ifc")]
        public void IfcStoreCanOpenSampleFiles(string file)
        {
            var config = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.Debug()
                .CreateLogger();
            var logger = (new LoggerFactory()).AddSerilog(config).CreateLogger(typeof(IModel));

            var exception = Record.Exception(() =>
            {
                using var model = IfcStore.Open(file);
            });
            exception.Should().BeNull();
        }

    }
}
