export class Products {
  constructor(public id: number, public name: string,public price: number, public isActive: boolean) {
    this.id = id;
    this.name = name;
    this.price = price;
    this.isActive =isActive;
  }

}

export class Model {
  products: Array<Products>;

  constructor(){
    this.products = [
      new Products(1,"samsung s5",10,false),
      new Products(2,"samsung s6",10,true),
      new Products(3,"samsung s7",10,false),
      new Products(4,"samsung s8",10,true),
      new Products(5,"samsung s9",10,true),
      new Products(6,"samsung s10",10,false)
    ];
  }
}

