f_pid="game.pid"
if [ -f "$f_pid" ];
then
	id=`head -1 $f_pid`
	kill $id
	while [ true ]
	do
		if [ ! -f "$f_pid" ]; then
		 echo "safe stop game at pid[$id]"
		 echo "good bye!"
		 break;
		else
		 echo "wait stop..."
		 sleep 1
		fi
	done
fi
echo "hi!"
echo "game start..."
sleep 1
sh start.sh