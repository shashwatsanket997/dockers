#!/bin/sh

if [ "$1" = "" ]; then
        echo "docker-machine create --driver amazonec2 <name of the server>"
        exit 0
fi


eval $(docker-machine env -u)

docker-machine rm -f $1
sleep 15
docker node rm $1
sleep 2

echo "docker-machine create --driver amazonec2 --amazonec2-access-key AKIAI572MDJWHXUP7ICQ --amazonec2-secret-key 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 --amazonec2-region ap-south-1 $1"

docker-machine create --driver amazonec2 --amazonec2-access-key AKIAI572MDJWHXUP7ICQ --amazonec2-secret-key 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 --amazonec2-region us-east-2a $1


TOKEN=$(docker swarm join-token worker -q)
echo $TOKEN
#docker node rm --force $1
eval $(docker-machine env $1)

case $DOCKER_MACHINE_NAME in
	$1)
		#sleep 2
        #docker swarm leave --force
        sleep 10
        echo "joining swarm"
        docker swarm join --token $TOKEN 172.31.35.74:2377

        sleep 10
        eval $(docker-machine env -u)
		;;
	*)
		echo "Sorry, I don't understand"
		eval $(docker-machine env -u)
		;;
esac

#docker node rm worker

