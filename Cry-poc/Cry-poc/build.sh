echo "building image..."
docker build -t crypoc .

echo "tagging image..."
docker tag crypoc hellcaller89/crypoc:latest 
docker tag crypoc hellcaller89/crypoc:v0.01

echo "Pushing image..."
docker push hellcaller89/crypoc:latest
docker push hellcaller89/crypoc:v0.01