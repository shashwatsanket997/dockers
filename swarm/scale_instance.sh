#!/bin/sh

if [ "$1" = "" ]; then
	echo "Enter the number of the replicas required"
	exit 0
fi


timeout 30s docker service scale test=$1

