import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Order } from '../model/order';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  constructor(private http: HttpClient) { 

  }

  private readonly url = 'api/Order';

  sendOrder(order: Order) {
    return this.http.post<Order>(this.url, order).subscribe();
  }
}
