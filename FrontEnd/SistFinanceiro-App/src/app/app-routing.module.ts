import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DespesasComponent } from './pages/despesas/despesas.component';
import { LucrosComponent } from './pages/lucros/lucros.component';
import { WelcomeComponent } from './pages/welcome/welcome.component';

const routes: Routes = [
  {path: '', pathMatch: 'full', redirectTo: '/welcome' },
  {path: 'welcome', component: WelcomeComponent},
  {path: 'despesas', component : DespesasComponent},
  {path: 'lucros', component : LucrosComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
