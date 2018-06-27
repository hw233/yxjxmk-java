id=`head -1 game.pid`
echo "-----------------------------------"
echo "-------------- Start --------------"
kill $id
echo "killed $id"
echo "--------------- end ---------------"
echo "-----------------------------------"
echo "Please see your game log, bye bye!"