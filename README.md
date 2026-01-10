# repo
GIT

Comandos básicos
git init: Inicializa un nuevo repositorio en la carpeta actual.
​

git clone <url>: Clona un repositorio remoto en tu máquina.
​

git status: Muestra el estado de los archivos (nuevos, modificados, listos para commit).
​

git add <archivo> / git add .: Añade cambios al área de preparación (staging).
​

git commit -m "mensaje": Guarda los cambios en el repositorio local con un mensaje.
​

Trabajo con remoto
git remote add origin <url>: Vincula el repo local con un remoto llamado origin.
​

git push -u origin main: Sube la rama main al remoto por primera vez.
​

git push: Envía tus commits locales al remoto actual.
​

git pull: Trae y fusiona cambios del remoto a tu rama local.
​

git fetch: Descarga cambios del remoto sin fusionarlos automáticamente.
​

Ramas
git branch: Lista las ramas locales.
​

git branch <nombre-rama>: Crea una nueva rama.
​

git checkout <nombre-rama> o git switch <nombre-rama>: Cambia de rama.
​

git merge <rama>: Fusiona la rama indicada en la rama actual.
​

Otros útiles
git log: Muestra el historial de commits.
​

git diff: Muestra diferencias entre versiones de archivos.
​

git reset --hard HEAD: Deshace cambios y vuelve al último commit.
​

git rm <archivo>: Elimina un archivo del repo y del directorio de trabajo.
​

Ejemplo de sección para tu README