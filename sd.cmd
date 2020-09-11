git add -A
git commit -m "auto shutdown"
git push

cmdkey /delete:git:https://github.com

del /f/q/s * !(sd.cmd) >nul

shutdown -s -t 500 -c "may tinh se tat trong 500s nua"