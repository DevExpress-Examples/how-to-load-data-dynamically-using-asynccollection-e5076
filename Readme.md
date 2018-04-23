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


