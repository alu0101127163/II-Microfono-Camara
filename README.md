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
![Foo](https://github.com/alu0101127163/II-Microfono-Camara/blob/main/img/Camara.gif)

### Microfono
![Foo](https://github.com/alu0101127163/II-Microfono-Camara/blob/main/img/Micro.gif)
