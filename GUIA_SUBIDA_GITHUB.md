# Guía para Publicar el Repositorio en GitHub

**Estudiante:** Cristian Omar Jordan Perez  
**Solución:** `COJP.sln`  

El repositorio Git ya ha sido inicializado localmente con todos los commits estructurados correspondientes a cada fase del desarrollo. Sigue estos pasos para subirlo a tu cuenta de GitHub:

---

## Opción A: Crear Repositorio desde GitHub Web (Recomendado)

1. Abre tu navegador e ingresa a [https://github.com/new](https://github.com/new).
2. Configura los datos del repositorio:
   - **Repository name:** `GuiaPractica1-PruebasUnitarias-COJP` (o el nombre que prefieras).
   - **Description:** `Guía Práctica 1: Pruebas Unitarias con MSTest y xUnit - Solución COJP`.
   - **Visibility:** Selecciona **Public** (o Private según prefiera el docente).
   - **IMPORTANTE:** **NO** marques las casillas de "Add a README file", "Add .gitignore" ni "Choose a license" (porque ya los creamos localmente).
3. Haz clic en **Create repository**.
4. Copia el comando proporcionado para "push an existing repository from the command line" o ejecuta los siguientes comandos en la terminal de este proyecto:

```bash
# Vincular con tu repositorio remoto (reemplaza 'TU_USUARIO' por tu usuario real de GitHub)
git remote add origin https://github.com/TU_USUARIO/GuiaPractica1-PruebasUnitarias-COJP.git

# Enviar la rama main con todo el historial de commits
git push -u origin main
```

---

## Opción B: Si tienes GitHub CLI (`gh`) Instalado

Si tienes instalado GitHub CLI, puedes crearlo y publicarlo directamente con un solo comando:

```bash
gh repo create GuiaPractica1-PruebasUnitarias-COJP --public --source=. --remote=origin --push
```

---

## Verificación del Historial de Commits

Para comprobar antes de subir que todos tus commits están listos:

```bash
git log --oneline --graph --decorate
```

Deberás ver la secuencia completa de commits:
- `chore: Configuracion inicial del repositorio con gitignore y README`
- `chore: Creacion de la solucion COJP.sln para Cristian Omar Jordan Perez`
- `feat: Implementacion de la biblioteca de clases COJP.Temperatura con metodos de conversion`
- `test: Implementacion de pruebas unitarias con MSTest para COJP.Temperatura`
- `feat: Implementacion de la biblioteca de clases COJP.Cadenas con manipulacion de texto`
- `test: Implementacion de pruebas unitarias con xUnit para COJP.Cadenas`
- `docs: Documentacion de casos de prueba para Azure DevOps y guias de entrega`
