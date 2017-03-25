cd ECommMvc
dotnet restore
dotnet build
dotnet publish -c Release -o output
cd ..
docker-compose up --build
