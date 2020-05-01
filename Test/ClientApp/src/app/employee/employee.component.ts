import { Component, OnInit } from '@angular/core';

import { Employee } from '../Models/employee';
import { EmployeeService } from '../../Services/employee-service.service';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  constructor(private employeeService: EmployeeService, private modalService: NgbModal) { }
  public employees: Employee[];

  ngOnInit() {
    this.employeeService.getEmployees().subscribe(res => {
      this.employees = res;
    });
  }


}
