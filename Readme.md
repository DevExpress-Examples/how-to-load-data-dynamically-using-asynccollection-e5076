<!-- default file list -->
*Files to look at*:

* [NavigationTypeProvider.cs](./CS/App1/Common/NavigationTypeProvider.cs)
* [StandardStyles.xaml](./CS/App1/Common/StandardStyles.xaml) (VB: [StandardStyles.xaml](./VB/App1/Common/StandardStyles.xaml))
* [MainPage.xaml](./CS/App1/MainPage.xaml) (VB: [MainPage.xaml.vb](./VB/App1/MainPage.xaml.vb))
* [MainPage.xaml.cs](./CS/App1/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/App1/MainPage.xaml.vb))
* [Reference.cs](./CS/App1/Service References/ServiceReference1/Reference.cs) (VB: [Reference.vb](./VB/App1/Service References/ServiceReference1/Reference.vb))
* [IService1.cs](./CS/WebApplication1/IService1.cs) (VB: [IService1.vb](./VB/WebApplication1/IService1.vb))
* [Service1.svc.cs](./CS/WebApplication1/Service1.svc.cs) (VB: [Service1.svc.vb](./VB/WebApplication1/Service1.svc.vb))
<!-- default file list end -->
# How to: Load data dynamically using AsyncCollection


<p>This example demonstrates how to use <strong>GridControl</strong> with our <strong>AsyncCollection</strong>. This collection allows loading data on-demand, so it may be very useful if you obtain data from a web service and don't want to wait until all data is loaded. Its constructor receives two parameters:</p><p>1. A callback that returns the total number of items</p><p>2. A callback that returns items from required positions.</p><p>For example:<br />


```cs
var Items = new AsyncCollection<Item>(
   async () => { return 1000; },
   async (int skipCount, int takeCount) => {
       return await Service1.GetDataAsync(skipCount, takeCount);
   });
```

 </p>

<br/>


