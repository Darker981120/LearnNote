## create a new repository on the command line
```
echo "# LearnNote" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M master
git remote add origin https://github.com/Darker981120/LearnNote.git
git push -u origin master
```
## push an existing repository from the command line
```
git remote add origin https://github.com/Darker981120/LearnNote.git
git branch -M master
git push -u origin master
```
## git clone
```
git clone <repo>
git clone <repo> <directory>
```
* **\<repo\>**: Git仓库
* **directory**: 本地目录

## git config
显示当前的 git 配置信息：
```
git config --list
credential.helper=osxkeychain
core.repositoryformatversion=0 
core.filemode=true 
core.bare=false 
core.logallrefupdates=true 
core.ignorecase=true 
core.precomposeunicode=true
```
编辑 git 配置文件:
```
git config -e # 针对当前仓库 
```
或者：
```
git config -e --global  # 针对系统上所有仓库
```
设置提交代码时的用户信息：
```
git config --global user.name "runoob"
git config --global user.email test@runoob.com
```
如果去掉 **--global** 参数只对当前仓库有效。

## git status
用于查看在你上次提交之后是否有对文件进行再次修改。
通常我们使用  -s  参数来获得简短的输出结果：
```
git status -s
```

### git add
添加一个或多个文件到暂存区：
```
git add [file1]  [file2]  ...
```
添加指定目录到暂存区，包括子目录：
```
git add [dir]
```
添加当前目录下的所有文件到暂存区：
```
git add .
```

## git commit
提交暂存区到本地仓库中:
```
git commit -m [message]
```
[message] 可以是一些备注信息。

提交暂存区的指定文件到仓库区：
```
$ git commit [file1]  [file2]  ...  -m [message]
```
**-a**  参数设置修改文件后不需要执行 git add 命令，直接来提交
```
$ git commit -a
```

## git reset
git reset 命令用于回退版本，可以指定退回某一次提交的版本。
git reset 命令语法格式如下：
```
git reset [--soft |  --mixed |  --hard]  [HEAD]
```
**--mixed**  为默认，可以不用带该参数，用于重置暂存区的文件与上一次的提交(commit)保持一致，工作区文件内容保持不变。
```
git reset [HEAD]
```
**--soft**  参数用于回退到某个版本：
```
git reset --soft HEAD
```
**-hard**  参数撤销工作区中所有未提交的修改内容，将暂存区与工作区都回到上一次版本，并删除之前的所有信息提交：
```
git reset --hard HEAD
```
**HEAD 说明：**
-   HEAD 表示当前版本
-   HEAD^ 上一个版本
-   HEAD^^ 上上一个版本
-   HEAD^^^ 上上上一个版本
-   以此类推... 

可以使用 ～数字表示
-   HEAD~0 表示当前版本
-   HEAD~1 上一个版本
-   HEAD^2 上上一个版本
-   HEAD^3 上上上一个版本
-   以此类推...

## git diff
显示暂存区和工作区的差异:
```
git diff [file]
```
显示暂存区和上一次提交(commit)的差异:
```
git diff --cached [file]  
或
git diff --staged [file]
```
显示两次提交之间的差异:
```
git diff [first-branch]...[second-branch]
```
查看已缓存的与未缓存的所有改动：
```
git diff HEAD
```
显示摘要而非整个 diff：
```
git diff --stat
```

## git rm
将文件从暂存区和工作区中删除：
```
git rm <file>
```
如果删除之前修改过并且已经放到暂存区域的话，则必须要用强制删除选项 -f。
```
git rm -f <file>
```
如果想把文件从暂存区域移除，但仍然希望保留在当前工作目录中，换句话说，仅是从跟踪清单中删除，使用 --cached 选项即可
```
git rm --cached <file>
```

## git mv
git mv 命令用于移动或重命名一个文件、目录或软连接。
```
git mv [file] [newfile]
```
如果新但文件名已经存在，但还是要重命名它，可以使用  **-f**  参数：
```
git mv -f [file] [newfile]
```

## git log
查看历史提交记录。
```
git log
```
可以用 **--oneline** 选项来查看历史记录的简洁的版本。
可以用 **--graph** 选项，查看历史中什么时候出现了分支、合并。以下为相同的命令，开启了拓扑图选项。
可以用 **--reverse** 参数来逆向显示所有日志。
可以用 **--author** 选项，查找指定用户的提交日志。
如果你要指定日期，可以执行几个选项：**--since** 和 **--before**，但是你也可以用 **--until** 和 **--after**。

## git blame
要查看指定文件的修改记录可以使用 git blame 命令
```
git blame <file>
```

## git remote
用于在远程仓库的操作
显示所有远程仓库：
```
git remote -v
```
**origin** 为远程地址的别名。
显示某个远程仓库的信息：
```
git remote show [remote]
```
添加远程版本库：
```
git remote add [shortname]  [url]
```
其他相关命令：
```
git remote rm name # 删除远程仓库 
git remote rename old_name new_name # 修改仓库名
```

## git fetch
用于从远程获取代码库

## git pull
用于从远程获取代码并合并本地的版本。
git pull 其实就是 git fetch 和 git merge FETCH_HEAD 的简写。
```
git pull <远程主机名>  <远程分支名>:<本地分支名>
git pull
git pull origin
```
将远程主机 origin 的 master 分支拉取过来，与本地的 brantest 分支合并。
```
git pull origin master:brantest
```
如果远程分支是与当前分支合并，则冒号后面的部分可以省略。
```
git pull origin master
```

## git push
用于从将本地的分支版本上传到远程并合并。
命令格式如下：
```
git push <远程主机名>  <本地分支名>:<远程分支名>
```
如果本地分支名与远程分支名相同，则可以省略冒号：
```
git push <远程主机名>  <本地分支名>
```
如果本地版本与远程版本有差异，但又要强制推送可以使用 --force 参数：
```
git push --force origin master
```
删除主机但分支可以使用 --delete 参数，以下命令表示删除 origin 主机的 master 分支：
```
git push origin --delete master
```

## git 分支
列出分支基本命令：
```
git branch
```
创建分支命令：
```
git branch (branchname)
```
切换分支命令:
```
git checkout (branchname)
```
当你切换分支的时候，Git 会用该分支的最后提交的快照替换你的工作目录的内容， 所以多个分支不需要多个目录。
合并分支命令:
```
git merge
```
删除分支命令：
```
git branch -d (branchname)
```

## git tag
如果你达到一个重要的阶段，并希望永远记住那个特别的提交快照，你可以使用 git tag 给它打上标签。
查看所有标签
```
git tag
```
-a 选项意为"创建一个带注解的标签"。
```
git tag -a v1.0
```
**git log --decorate** 时，我们可以看到我们的标签。

如果我们忘了给某个提交打标签，又将它发布了，我们可以给它追加标签。
```
git tag -a v0.9  85fc7e7
```
