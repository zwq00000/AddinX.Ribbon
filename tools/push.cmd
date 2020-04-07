
Set Configuration=Release

cd ../src/ExcelDna.RibbonFluent

del bin/Release/*.nupkg -y

call dotnet pack --force  -c %Configuration%

call dotnet nuget push -k oy2krxnofpm5747w5zsqimphkc2y2ddurk7qceh72tnd34 -s https://www.nuget.org

cd ../tools