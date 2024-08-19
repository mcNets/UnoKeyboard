# UnoKeyboard

UnoKeyboard es un control que muestra un teclado-en-pantalla, diseñado para ejecutarse en las plataformas Desktop, WASM y Windows. Pensado básicamente para dispositivos con pantalla tàctil.

## Características

- Multi-plataforma.
- Diseño personalizado.
- Soporte para temas.
- Apariencia personalizada (Fuente y tamaño)

## Como usar UnoKeyboard

El control se encuentra disponible como paquete [Nuget](https://www.nuget.org/packages/UnoKeyboard) o, si lo prefieres puedes descargar el codigo fuente y añadirlo a tu proyecto desde el repositorio de [Github](https://github.com/mcNets/UnoKeyboard).


### Como un control de usuario.

Añade una referencia el espacio de nombres `UnoKeyboard.Controls` y un nuevo control a tu archivo:

```xml
<ukc:UnoKeyboard x:Name="MyKeyboard"
                 Height="300"
                 Visibility="Collapsed"
                 HandleFocusManager="True" />
```

### Usando un me
