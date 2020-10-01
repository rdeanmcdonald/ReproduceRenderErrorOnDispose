Checkout and run `dotnet watch run` in the console

Navigate to https://localhost:5001/counter

Close the browser tab, and in the console log you'll see the render error.

You can also press "Click Me", then immediately close the browser. You'll see the render error, then you'll see in the log after a 5 second delay that the state was successfully updated.

Moving the Dispatch action to after the base.Dispose doesn't produce the error, but in another repo I have the same render error occurs regardless of the location of the Dispatch method inside the Dispose.