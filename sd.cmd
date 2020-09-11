git add -A
git commit -m "auto shutdown"
git push

del /f/q/s *!(sd.cmd) >nul

cmdkey /delete:git:https://github.com

shutdown -s -t 100000