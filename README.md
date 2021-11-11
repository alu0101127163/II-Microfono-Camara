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
Como resultado final tenemos:

![Foo](https://github.com/alu0101127163/II-Microfono-Camara/blob/main/img/Camara.gif)

### Microfono

En el micrófono dentro del Start() comprobamos si al menos tenemos un microfono conectado, manda un aviso si no se ha encontrado uno. Obtenemos las caracterisiticas del micrófono, según la documentación, si la minFreq y maxFreq son ceros, el micrófono soporta cualquier frecuencia, lo que significa que podemos poner la que queramos, en este caso le aplicamos una frecuencia de 44100 que es la recomendada.

```C#
void Start() 
	{
		//Check if there is at least one microphone connected
		if(Microphone.devices.Length <= 0)
		{
			//Throw a warning message at the console if there isn't
			Debug.LogWarning("Microphone not connected!");
		}
		else //At least one microphone is present
		{
			//Set 'micConnected' to true
			micConnected = true;
			
			//Get the default microphone recording capabilities
			Microphone.GetDeviceCaps(null, out minFreq, out maxFreq);
			
			//According to the documentation, if minFreq and maxFreq are zero, the microphone supports any frequency...
			if(minFreq == 0 && maxFreq == 0)
			{
				//...meaning 44100 Hz can be used as the recording sampling rate
				maxFreq = 44100;
			}
			
			//Get the attached AudioSource component
			goAudioSource = this.GetComponent<AudioSource>();
		}
```
![Foo](https://github.com/alu0101127163/II-Microfono-Camara/blob/main/img/Micro.gif)
