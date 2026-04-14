List<DispositivoBase> menu = new List<DispositivoBase>;
MenuCasaInteligente panel=new MenuCasaInteligente(menu);
menu.Add(new Televisor(20, "Tele1", "003", 40));
menu.Add(new AireAcondicionado(2, "AireSala", "005", 23));
menu.Add(new PuertaInteligente(true, false, "PuertaFrente", "008"));
menu.Add(new Radio(23, "RadioDorm", "001", 23.5m));
panel.Menu();
