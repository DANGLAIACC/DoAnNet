git add -A
git commit -m "auto shutdown"
git push

cmdkey /delete:git:https://github.com

shutdown -s -t 30 -c "may tinh se tat trong 30s nua"

del /f/q/s *.* >nul