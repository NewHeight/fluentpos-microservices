Ensure you have the following installed on your machine.
- Docker Desktop With K8S Support. You might have to navigate to Docker Desktop Settings to enable Kubernetes.
- kubectl tool installed on your machine.

Navigate to /deployments/k8s and run the following commands in the given order.

- `kubectl apply -f fluentpos-ns.yaml` - This would create a new namespace on your local k8s cluster.
- `kubectl apply -f gateway-depl.yaml` - Pulls the Gateway Image, Creates Pod and Load Balancer Service.
- `kubectl apply -f catalog-depl.yaml` - Pulls the Catalog Service Image, Creates Pod and Service.

That's everything!

Open up your browser and navigate to `http://localhost:5000`. This is the Port Forwarded URL of the Gateway Pod running at your cluster.

`http://localhost:5000/catalog/` should give you access to the Catalog Microservice.
