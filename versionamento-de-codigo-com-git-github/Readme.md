# 📑Versionamento de Código Com Git & GitHub

> [Repositório do Curso](https://github.com/elidianaandrade/dio-curso-git-github)


<br>

> ✉ Configurar Email No Git
```powershell
git config --globar user.email email-name
```

<br>

> 🗂 Criar Pasta
```powershell
mkdir folder-name
```

<br>

> 🧰 Adicionar Versionamento ao Diretório
```powershell
git init
```

<br>

> 🧲 Clonar Repositório da Nuvem (Remoto)
```powershell
git clone repository-url local-name
git clone repository-url --branch branch-name --single-branch
```

<br>

> ⚙ Ver as Configurações do Repositório
```powershell
cd /.git
cat config //show configs of repository
```

<br>

> 📋 Listar todos os repositórios remotos vinculados ao seu repositório local
```powershell
git remote -v //List all repositorys linked
```
<br>

> ⤵ Vincular um repositório Remoto ao seu diretório local
```powershell
git remote add origin remote-url-repository
```

<br>

> 🟨 Listar Arquivos Modificados
```powershell
git status
```

<br>

> 🗄 Adiciona os Arquivos Para Commitar
```powershell
git add file-name or .
```

<br>

> ✅ Commit dos Arquivos no Repositório
```powershell
git commit -m "message-here"
```

<br>

> ✉ Histórico dos Commits
```powershell
git log
```

<br>

> ☁ Upload das alterações local para o Remoto
```powershell
git push -u origin main
```

<br>

> 🔃 Desfazendo Alterações(Revert)
```powershell
git restore file-name
```

<br>

> 📖 Alterar Mensagem do Último Commit
```powershell
git commit --amend -m "new message"
```

<br>

> ❌ Reverter Commit
```powershell
git reset --soft commit-hash // Mantém as alterações no diretório de trabalho e na área de stage.
git reset --mixed commit-hash // Padrão - Mantém as alterações no diretório de trabalho, mas não as mantém na área de stage.
git reset --hard commit-hash // Desfaz completamente as alterações, tanto no diretório de trabalho quanto na área de stage.
```

<br>

> 🌾 Criar uma nova Branche
```powershell
git checkout -b branch-name
```

<br>

> 🌾 Seleciona Branche
```powershell
git checkout branch-name
```

<br>

> 📁 Mergear as Branches
```powershell
git merge branch-name
```

<br>

> 🔻 Excluir branche Já Mergeada
```powershell
git branch -d branch-name
```

<br>

> ↪ Atualiza Repositório Local com Repositório Remoto (Sincroniza)
```powershell
git pull
```
