This repro is built using the .NET 8 Blazor WebApp sample. 

I have added a second counter page that resides on the server and uses a scoped service to store the current value of the counter.

If one opens the Server Counter Page and clicks several times the counter increments. Switching to the Home Page and back keeps the counter.

Now Click on the Counter page. This one resides in the WebAssembly. One can see that after a short while the circuit of the Blazor app is closed.
If one return to the Serer Counter Page after that, the counter is reset and starts at 0 again
