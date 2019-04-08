import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';
import { MemberEditComponent } from '../members/member-edit/member-edit.component';

@Injectable()

export class PreventUnsavedChanges implements CanDeactivate<MemberEditComponent> {
    canDeactivate(component: MemberEditComponent) {

        if (component.editForm.dirty) {
            return confirm('Are you Sure to leave the page, Any Unsaved changes will be Lost!');
        }
        return true;
    }
}
