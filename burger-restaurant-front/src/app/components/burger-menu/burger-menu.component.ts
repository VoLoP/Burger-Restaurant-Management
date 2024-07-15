import { Component, Injectable } from '@angular/core';
import { MatPaginatorIntl, MatPaginatorModule } from '@angular/material/paginator';
import {Subject} from 'rxjs';
import { ɵ$localize } from '@angular/localize';
import { CommonModule } from '@angular/common';
import { PageEvent } from '@angular/material/paginator';
import { RouterOutlet } from '@angular/router';

@Injectable()
export class MyPag implements MatPaginatorIntl {
  changes = new Subject<void>();

  firstPageLabel = ɵ$localize`First page`;
  itemsPerPageLabel = ɵ$localize`Items per page:`;
  lastPageLabel = ɵ$localize`Last page`;

  nextPageLabel = 'Next page';
  previousPageLabel = 'Previous page';

  getRangeLabel(page: number, pageSize: number, length: number): string {
    if (length === 0) {
      return ɵ$localize`Page 1 of 1`;
    }
    const amountPages = Math.ceil(length / pageSize);
    return ɵ$localize`Page ${page + 1} of ${amountPages}`;
  }
}

@Component({
  selector: 'app-burger-menu',
  standalone: true,
  imports: [RouterOutlet, CommonModule, MatPaginatorModule],
  templateUrl: './burger-menu.component.html',
  styleUrl: './burger-menu.component.scss',
  providers: [{ provide: MatPaginatorIntl, useClass: MyPag }]
})
export class BurgerMenuComponent {
  page: number = 1;
  pageSize: number = 2;
  burgerMenus = [
    { id: 1, name: 'Burger', description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua', price: '$3' },
    { id: 2, name: 'Nice Burger', description: 'Hi', price: '$2' },
    { id: 3, name: 'Net Burger', description: 'Hi', price: '$20' },
    { id: 4, name: 'Burgerrr', description: 'Hi', price: '$7' },
    { id: 5, name: 'BurgerBurger', description: 'Hi', price: '$34' },
    { id: 6, name: 'Wow Burger', description: 'Hi', price: '$2' },
    { id: 7, name: 'Small Burger', description: 'Hi', price: '$1' },
    { id: 8, name: 'Big Burger', description: 'Hi', price: '$8' },
  ];

  changePage(event: PageEvent) {
    this.page = event.pageIndex + 1;
    this.pageSize = event.pageSize;
  }
}
