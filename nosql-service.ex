# nosql-service.ex
defmodule NoSQLService do
  use Plug.Router

  plug :match
  plug :dispatch

  get "/nosql" do
    send_resp(conn, 200, "Elixir NoSQL Service: Data stored successfully!")
  end
end

Plug.Cowboy.http NoSQLService, []
