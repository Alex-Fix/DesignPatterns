using Adapter;

Client client = new();
Target target;

target = new Target();
client.Request(target);

target = new Adapter.Adapter();
client.Request(target);