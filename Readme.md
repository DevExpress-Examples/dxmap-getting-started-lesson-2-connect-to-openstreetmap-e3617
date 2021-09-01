<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571083/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3617)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
<!-- default file list end -->

# How to: Connect to OpenStreetMap


This example shows how to use the [OpenStreetMapDataProvider](https://docs.devexpress.com/WPF/DevExpress.Xpf.Map.OpenStreetMapDataProvider) class to connect the [Map Control](https://docs.devexpress.com/WPF/115085/controls-and-libraries/map-control) to the [OpenStreetMap](https://www.openstreetmap.org) image tile service.

> Review the [Copyright and License](https://www.openstreetmap.org/copyright) and [Tile usage policy](https://operations.osmfoundation.org/policies/tiles/) pages before using map images in the OpenStreetMap format.

To use the **OpenStreetMap** provider, you should provide the [UserAgent](https://docs.devexpress.com/WPF/DevExpress.Xpf.Map.MapWebRequestEventArgs.UserAgent) parameter with a valid value to identify your application.

Set the [OpenStreetMapDataProvider.TileUriTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Map.OpenStreetMapDataProvider.TileUriTemplate) property to a tile's URL. You can use the public OpenStreetMap server that has limitations described in the [Tile usage policy](https://operations.osmfoundation.org/policies/tiles/). To do this, set **TileUriTemplate** to *"https://{subdomain}.tile.openstreetmap.org/{tileLevel}/{tileX}/{tileY}.png"*. You can also deploy your own tile server.

See also:
* [Image Tile Providers](https://docs.devexpress.com/WPF/115780/controls-and-libraries/map-control/map-image-data/image-tile-providers)
