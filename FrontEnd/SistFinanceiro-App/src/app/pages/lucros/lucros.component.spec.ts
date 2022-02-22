import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LucrosComponent } from './lucros.component';

describe('LucrosComponent', () => {
  let component: LucrosComponent;
  let fixture: ComponentFixture<LucrosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LucrosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LucrosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
