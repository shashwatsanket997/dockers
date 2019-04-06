#!/bin/sh

if [ "$1" = "" ]; then
	echo "Enter the name of the node"
	exit 0
fi

eval $(docker-machine env -u)

docker-machine rm -f $1
sleep 60


docker node rm $1
sleep 5

#timeout 20s docker service scale test=$2

