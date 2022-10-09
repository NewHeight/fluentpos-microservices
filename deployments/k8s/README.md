Ensure you have the following installed on your machine.
- Docker Desktop With K8S Support. You might have to navigate to Docker Desktop Settings to enable Kubernetes.
- kubectl tool installed on your machine.

Navigate to /deployments/k8s and run the following commands in the given order.

- `kubectl apply -f fluentpos-ns.yaml` - This would create a new namespace on your local k8s cluster. It's important to run this command first.
- `kubectl config set-context --current --namespace=fluentpos` - This sets the current working namespace to fluentpos.
- `kubectl apply -f .` - Creates all the required K8S Resources and deploys to the cluster.

That's everything!

Open up your browser and navigate to `http://localhost:5000`. This is the Port Forwarded URL of the Gateway Pod running at your cluster.

`http://localhost:5000/catalog/` should give you access to the Catalog Microservice.
