@echo off
set directory=..
set "foldersToDelete=bin obj scriptcs_bin"

for %%i in (%foldersToDelete%) do (
    for /d /r "%directory%" %%j in (%%i) do (
        rd /s /q "%%j"
    )
)
pause
