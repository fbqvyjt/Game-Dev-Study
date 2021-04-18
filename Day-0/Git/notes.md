# Git Notes
Notes on the ins and outs of git and github.

- `git` → list all git command list
   - version control is an overview of all different changes youve made to a project (or file you are working on).
   - git handles everything in version control

- `git init` → initialise a git repository (group of projects). you are now doing version control in git

- `git status` → checks the status of the changes made to the git

- always have a readme.md file in your git base folder that acts as a table of content/index

- `git add readme.md` →  watches the file for any changes

- `git rm --cached readme.md` → makes the git not track the specific file, but not delete the file

- `git add .` → watches everything within the directory

- `git commit -m "Added readme"` → saves changes of files being watched. The "" just are a word or phrase to describe your changes; you can put anything.

- `git remote add origin link` → looks for a remote location and adds git with a new name and where it comes from (link from Github).

- `git push -u origin main` → you do this the first time,  afterwards you:
    - then `git add .`
    - then `git commit -m .`
    - then `git push`