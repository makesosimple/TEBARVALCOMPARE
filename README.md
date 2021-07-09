# IBB Portal

Will be designed and developed in MVC Pattern of Microsoft.NET. Core objective for this project is to automize the project development process of Istanbul Büyükşehir Belediyesi. 

## Version
0.0.0

## Installation

Use the package manager [npm](https://www.npmjs.com/package/npm) to install static frontend files.

```bash
npm install
```

## Installation for ASP.NET Core MVC

### !Warning (All of the names can be customized but we highly encourage to use it this way as it is the current best approach to Git Flow)  
### !Warning (It is OK to use Visual Studio Git property)  

1. First create an empty directory in your computer either from CLI or Graphical Interface.

```bash
mkdir IBBPortal
```

2. Change directory to the newly created folder and initialize Git Repository.

```bash
cd IBBPortal
git init
```

3. Add remote repository to your Git project.

```bash
git remote add origin https://github.com/makesosimple/ibbportal/
```

4. Pull the "dev" branch to develop your assignments.

```bash
git pull origin dev
```

5. Open Visual Studio and migrate the database!!!!! To migrate database, open Tools -> NuGet Package Manager -> Package Manager Console. Then type the following code. (This is important)

```bash
Update-Database
```

6. After the assignments are finished, add and commit your changes.

```bash
git add .
git commit -m "Your Header for the Commit."
```

7. Push your commit to a new branch and create a pull request from Github. Please read the "How does Git Flow Work?" chapter and name your branches according to the 5. item!

```bash
git push origin (new-branch)
```

8. Wait for the Repository Manager to examine your code. If all is OK, congratulations!

## Author
Project Author: makesosimple

## Private Repo Warning!!
- Initially this repository is started as a closed-source project. Unless the author says otherwise, it will be closed for public access. 
- Only repository manager can merge pull requests so it is restricted for Contributers to merge a request. 
- Any database change should be commented on the pull request. (If migration is available, comment it too.)

## Git Flow Warning!!
- Project workflow framework is based on the original Git Flow
- Developer should never change master. Access is restricted to dev branch only!
- Repository manager must follow changes and update dev and master branches simultaneouslty!! (This is the most important warning!)

## How does Git Flow Work?
1. Pull the dev branch first.
2. Check the config file and change it if it is in production mode!
3. Do your assignments and updates.
4. Commit you changes with explanation!
5. Push it to a branch. It should be named in this syntax: {module_name}/ibb-{code}/{small-explanation}. For ex: insertProject/ibb-890/label-adjustment
6. Create a pull request and wait for the repository manager to check if changes are okay. 
7. If everyting checks out, re-change the config to production and if available get a production build.
8. Commit production build to a sub-branch named in this syntax: merge-master/ibb-{code}
9. Delete the sub branch afterwards.
10. ### If a hotfix or patch is needed immediately on a certain update, please name your branch as: ibb-{code}/hotfix!!
11. This step is recommended for version management. Please don't forget to edit README.md file after changes. 
- If it is a patch: x.x.1 (Edit the last number)
- If it is a minor update: x.1.x (Edit the second number)
- If it is a major update: 1.x.x (Edit the first number)
12. ### Always check live after the merge with master branch!

## License
Not licensed yet
