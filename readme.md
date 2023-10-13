# Get My Ip

dotnet restore
dotnet build
dotnet run

Now listening on: http://localhost:5043

docker build -t muhtalipdede/ip-api .
docker push muhtalipdede/ip-api

minikube start

kubectl apply -f my-ingress.yml
kubectl apply -f my-app-deployment.yml
kubectl apply -f my-service.yml

minikube service ip-api-service --url

minikube ip

export NO_PROXY=localhost,127.0.0.1,10.96.0.0/12,192.168.59.0/24,192.168.49.0/24,192.168.39.0/24

sudo minikube tunnel