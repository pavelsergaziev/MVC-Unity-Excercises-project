﻿//MVC на синглтоне.

//Controller-классы сваливаются в один MonoBehavior(в данном случае - ControllerHolder), который делается DontDestroyOnLoad, с дополнительной гарантией, что других инстансов этого класса создаться не может. В результате получается класс-синглтон.View-объекты в своих Start-ах обращаются к ControllerHolder и кэшируют находящиеся в нём Controller-объекты, реализующие нужные интерфейсы.

//Возможен вариант без синглтона и без DontDestroyOnLoad, просто MonoBehavior.