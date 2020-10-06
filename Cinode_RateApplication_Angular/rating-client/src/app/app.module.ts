import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { ProfileModule } from './profile/profile.module';
import { HttpClientModule } from '@angular/common/http';
import { AppStoreModule } from './store/store.module';
import { StatsModule } from './stats/stats.module';

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    ProfileModule,
    StatsModule,
    HttpClientModule,
    AppStoreModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
