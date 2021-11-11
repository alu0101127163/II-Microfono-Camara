# II-Microfono-Camara


### Camara

Para la camara lo primero que tenemos que hacer es inicializar la clase WebcamTexture, que traduce la información obtenida de dichos dispositivos a texturas 2D. Ahora lo para ver las imágenes grabadas, debe asociarse el objeto WebCamTexture al atributo mainTexture de un material o imagen y seguidamente llamar a la función Play() de dicho objeto.
Aqui en este fragmento de codigo lo podemos observar:

```C#
 void Start()
    {
        webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
```
Con esto ya podríamos ver nuestra cámara web en tiempo real sin ningún problema.

Lo que hacemos ahora es añadir los botones de "Pausa" y "Play", para permitir detener y reanudar la reproducción. Para ello usamos la funcion MonoBehaviour.OnGUI() que nos permite renderizar y manejar eventos de la GUI, en este caso los botones. Una vez hecho esto simplmente comprobamos que la camara este activa o no, y hacemos uso de la función Pause() o Play() de WebCamTexture. Nos quedaría algo asi:

```C#

 void OnGUI()
    {
        if (webcamTexture.isPlaying)
        {
            if(GUI.Button(new Rect(Screen.width/2-300, Screen.height/2+250, 100, 50), "Pausa"))
            {
                webcamTexture.Pause();
            }
        }

        if (!webcamTexture.isPlaying)
        {
            if(GUI.Button(new Rect(Screen.width/2-300, Screen.height/2+250, 100, 50), "Play"))
            {
                webcamTexture.Play();
             }
        }
    }
```
![Foo](https://github.com/alu0101127163/II-Microfono-Camara/blob/main/img/Camara.gif)

### Microfono
![Foo](https://github.com/alu0101127163/II-Microfono-Camara/blob/main/img/Micro.gif)
