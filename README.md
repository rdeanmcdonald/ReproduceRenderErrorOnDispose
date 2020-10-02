Checkout and run `dotnet watch run` in the console

Navigate to https://localhost:5001/counter

Close the browser tab, and in the console log you'll see the render error.

You can also press "Click Me", then immediately close the browser. You'll see the render error, then you'll see in the log after a 5 second delay that the state was successfully updated.

If you move the the Dispatch action to after the base.Dispose, the render error goes away. But in another repo I have the same render error occuring regardless of the location of the Dispatch method inside the Dispose, I'll work on a way to reproduce that here.

#UPDATE#
If you include a child FluxorComponent which  implements the `protected override Dispose(disposing)` then you'll see the Render error even if you put the Dispatch after base.Dispose().

To reproduce, checkout and run `dotnet watch run` in the console, navigate to https://localhost:5001/counter, close the browser tab and you'll see the error.