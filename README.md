# Cognitive Services Demo
>Para poder utilizar esta DEMO, es necesario generar una cuenta de Azure Storage con un contenedor de tipo blob para almacenar las imágenes a validar. Una vez que tengamos esto generado, obtenemos la cadena de conexión, el nombre de nuestro contenedor, y lo colocamos en la clase StorageServices.cs
Para más información sobre cómo crear y administrar este servicio, pueden consultar la siguiente página: [Acerca de las cuentas de Storage](https://docs.microsoft.com/en-us/azure/storage/storage-create-storage-account) 

>También es necesario obtener una llave para el API de Reconocimiento Facial de Azure Cognitive Services. Esta la pueden obtener dentro del portal de azure, o en la siguiente página: [Prueba Servicios Cognitivos](https://azure.microsoft.com/en-us/try/cognitive-services/my-apis)
>Seleccionen South Central US para obtener el servicio, y cuando obtengan su llave, es necesario ir al archivo Views/Home/Upload.cshtml y en las funciones en donde aparezca la variable subscriptionKey y en los request Headers de Ocp-Apim-Subscription-Key, agregar el valor que obtuvieron.
