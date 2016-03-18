namespace TypeProviderDemo

open Xamarin.Forms
open Xamarin.Forms.Xaml
open foursquare

type VenueListPage() = 
    inherit ContentPage()

    do base.LoadFromXaml(typeof<VenueListPage>) |> ignore

    let entry = base.FindByName<Entry>("entry")
    let listView = base.FindByName<ListView>("listView")

    let tableItems = foursquare.recommendations 

    do listView.ItemsSource <- tableItems

    let stacklayout = new StackLayout()
    do stacklayout.Children.Add(listView)
    do stacklayout.Padding <- new Thickness (5., Device.OnPlatform (20., 0., 0.), 5., 0.)

    do base.Padding <- Thickness(5.0, Device.OnPlatform(20.0, 5.0, 5.0), 5.0, 5.0)
    do base.Content <- stacklayout
