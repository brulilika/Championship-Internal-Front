var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhjVFpHaV5dX2NLfUN/T2JddVp5ZDU7a15RRnVfQ15jS3xRd0BkWHdYcA==;Mgo+DSMBPh8sVXJ0S0J+XE9HflRBQmJWfFN0RnNQdV90flFPcDwsT3RfQF5jSH1TdEdhWHpZcnRWRg==;ORg4AjUWIQA/Gnt2VVhkQlFadVdJXnxIYVF2R2BJdlRxcF9CaUwxOX1dQl9gSX9QdkdhW35bd3ZUTmA=;MTAzNDIwN0AzMjMwMmUzNDJlMzBJNlNBN0pkVmc4djQ3eU1PbEcvZUxmODhNR3gzbmQzSkRWWFgyK3FvTnJRPQ==;MTAzNDIwOEAzMjMwMmUzNDJlMzBHeEFVRXpSbWVMUXFXajZ3OC9vWE9QUmt2eThETkttbmJKQjRHc1MrZ3BVPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFxKVmBWf0x0RWFab1d6dVFMZFVBJAtUQF1hSn5SdUVhW31fdXNXTmJa;MTAzNDIxMEAzMjMwMmUzNDJlMzBMbmtwNjJqOVFxb1J1ZmdNM2xyaWl1NjdnVmIvd1k0VnNrcGI3bTBCTE9rPQ==;MTAzNDIxMUAzMjMwMmUzNDJlMzBUT2VYMzVNUnp3UTY1bW5iWEEzNld4aVNnY1gza3FnOFpPUitNb3Y4OTlZPQ==;Mgo+DSMBMAY9C3t2VVhkQlFadVdJXnxIYVF2R2BJdlRxcF9CaUwxOX1dQl9gSX9QdkdhW35bd3dQRmE=;MTAzNDIxM0AzMjMwMmUzNDJlMzBscWpPYS9Gd0hqaGZUTnVzbEY1RHBvb1JzNFYvTm9SQmlZSy9qdTdwdllrPQ==;MTAzNDIxNEAzMjMwMmUzNDJlMzBZdlkvdnJMZ2VLRFhpeTlsdklhcEg1R3NPVGtWaGFTOTJBbzJycm05Q0dBPQ==;MTAzNDIxNUAzMjMwMmUzNDJlMzBMbmtwNjJqOVFxb1J1ZmdNM2xyaWl1NjdnVmIvd1k0VnNrcGI3bTBCTE9rPQ==");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

