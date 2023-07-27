using WebSocketSharp;

internal class Program
{
    private static void Main(string[] args)
    {
        using (WebSocket ws = new WebSocket("ws://127.0.0.1:7890/EchoAll"))
        {
            ws.Connect();
            ws.OnMessage += Ws_OnMessage;
            ws.Send("Hello");
            Console.ReadKey();
        }

        static void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            Console.WriteLine("Receive from Server:" + DateTime.Now);


        }
    }
}