﻿namespace Kendo.Mvc.UI.Fluent.Tests
{
    using Kendo.Mvc.Tests;
    using Xunit;

    public class PivotDataSourceTransportBuilderTests
    {
        private readonly PivotTransport transport;
        private readonly PivotDataSourceTransportBuilder builder;

        public PivotDataSourceTransportBuilderTests()
        {
            transport = new PivotTransport();
            builder = new PivotDataSourceTransportBuilder(transport, TestHelper.CreateViewContext(), new UrlGenerator());
        }

        [Fact]
        public void Read_should_return_builder()
        {
            builder.Read(r => { }).ShouldBeSameAs(builder);
        }

        [Fact]
        public void Read_should_configure_read_options()
        {
            string url = "discoveryName";
            builder.Read(read => read.Url(url));
            transport.Read.Url.ShouldEqual(url);
        }

        [Fact]
        public void Connection_should_return_builder()
        {
            builder.Connection(r => { }).ShouldBeSameAs(builder);
        }

        [Fact]
        public void Connection_should_configure_connection_options()
        {
            string cubeName = "cubeName";
            builder.Connection(c => c.Cube(cubeName));
            transport.Connection.Cube.ShouldEqual(cubeName);
        }

        [Fact]
        public void Discover_should_return_builder()
        {
            builder.Discover(r => { }).ShouldBeSameAs(builder);
        }

        [Fact]
        public void Discover_should_configure_discovery_options()
        {
            string discover = "discoverName";
            builder.Discover(c => c.Url(discover));
            transport.Discover.Url.ShouldEqual(discover);
        }
    }
}