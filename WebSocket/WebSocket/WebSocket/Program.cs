using WebSocketSharp;
using WebSocketSharp.Server;

WebSocketServer wssv = new WebSocketServer("ws://127.0.0.1:7890");
wssv.AddWebSocketService<Echo>("/Echo");
wssv.AddWebSocketService<EchoAll>("/EchoAll");

wssv.Start();
Console.WriteLine("Server started ws/Echo");
Console.WriteLine("Server started ws/EchoAll");
Console.ReadLine();
wssv.Stop();

public class Echo : WebSocketBehavior
{
    public Echo() { }

    protected override void OnMessage(MessageEventArgs e)
    {
        var data = string.Empty;
        Console.WriteLine("============ Echo: =======");
        Console.WriteLine("Received Message: " + e.Data);

        Send(e.Data);
    }

}

public class EchoAll : WebSocketBehavior
{
    protected override void OnMessage(MessageEventArgs e)
    {
        Console.WriteLine("========== EchoAll: ======");
        Console.WriteLine("Received Message from EchoAll: " + e.Data);
        Sessions.Broadcast(e.Data);
    }

}