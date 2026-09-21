using DeliveryServiceLibInheritance;

DeliveryService deliveryService =new NormalDelivery();
deliveryService.Deliver();

DeliveryService deliveryService1 =new FastDelivery();
deliveryService1.Deliver();

FastDelivery fastDelivery =new InternationalDelivery();
fastDelivery.Deliver();

DeliveryService deliveryService2 = new InternationalDelivery();
deliveryService2.Deliver();