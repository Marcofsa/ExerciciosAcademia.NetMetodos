## API Report File for "components-srcs"

> Do not edit this file. It is a report generated by [API Extractor](https://api-extractor.com/).

```ts

import { _AbstractConstructor } from '@angular/material/core';
import { ActiveDescendantKeyManager } from '@angular/cdk/a11y';
import { AfterContentInit } from '@angular/core';
import { AfterViewInit } from '@angular/core';
import { BooleanInput } from '@angular/cdk/coercion';
import { CanDisableRipple } from '@angular/material/core';
import { ChangeDetectorRef } from '@angular/core';
import { _Constructor } from '@angular/material/core';
import { ControlValueAccessor } from '@angular/forms';
import { Directionality } from '@angular/cdk/bidi';
import { ElementRef } from '@angular/core';
import { EventEmitter } from '@angular/core';
import * as i0 from '@angular/core';
import * as i4 from '@angular/cdk/overlay';
import * as i5 from '@angular/material/core';
import * as i6 from '@angular/common';
import * as i7 from '@angular/cdk/scrolling';
import { InjectionToken } from '@angular/core';
import { MatFormField } from '@angular/material/form-field';
import { MatOptgroup } from '@angular/material/core';
import { _MatOptgroupBase } from '@angular/material/core';
import { MatOption } from '@angular/material/core';
import { _MatOptionBase } from '@angular/material/core';
import { MatOptionSelectionChange } from '@angular/material/core';
import { NgZone } from '@angular/core';
import { Observable } from 'rxjs';
import { OnChanges } from '@angular/core';
import { OnDestroy } from '@angular/core';
import { Overlay } from '@angular/cdk/overlay';
import { Platform } from '@angular/cdk/platform';
import { QueryList } from '@angular/core';
import { ScrollStrategy } from '@angular/cdk/overlay';
import { SimpleChanges } from '@angular/core';
import { TemplateRef } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { ViewContainerRef } from '@angular/core';
import { ViewportRuler } from '@angular/cdk/scrolling';

// @public
export function getMatAutocompleteMissingPanelError(): Error;

// @public
export const MAT_AUTOCOMPLETE_DEFAULT_OPTIONS: InjectionToken<MatAutocompleteDefaultOptions>;

// @public
export function MAT_AUTOCOMPLETE_DEFAULT_OPTIONS_FACTORY(): MatAutocompleteDefaultOptions;

// @public
export const MAT_AUTOCOMPLETE_SCROLL_STRATEGY: InjectionToken<() => ScrollStrategy>;

// @public
export function MAT_AUTOCOMPLETE_SCROLL_STRATEGY_FACTORY(overlay: Overlay): () => ScrollStrategy;

// @public
export const MAT_AUTOCOMPLETE_SCROLL_STRATEGY_FACTORY_PROVIDER: {
    provide: InjectionToken<() => ScrollStrategy>;
    deps: (typeof Overlay)[];
    useFactory: typeof MAT_AUTOCOMPLETE_SCROLL_STRATEGY_FACTORY;
};

// @public
export const MAT_AUTOCOMPLETE_VALUE_ACCESSOR: any;

// @public (undocumented)
export class MatAutocomplete extends _MatAutocompleteBase {
    // (undocumented)
    protected _hiddenClass: string;
    optionGroups: QueryList<MatOptgroup>;
    options: QueryList<MatOption>;
    // (undocumented)
    protected _visibleClass: string;
    // (undocumented)
    static ɵcmp: i0.ɵɵComponentDeclaration<MatAutocomplete, "mat-autocomplete", ["matAutocomplete"], { "disableRipple": "disableRipple"; }, {}, ["optionGroups", "options"], ["*"], false, never>;
    // (undocumented)
    static ɵfac: i0.ɵɵFactoryDeclaration<MatAutocomplete, never>;
}

// @public
export interface MatAutocompleteActivatedEvent {
    option: _MatOptionBase | null;
    source: _MatAutocompleteBase;
}

// @public
export abstract class _MatAutocompleteBase extends _MatAutocompleteMixinBase implements AfterContentInit, CanDisableRipple, OnDestroy {
    constructor(_changeDetectorRef: ChangeDetectorRef, _elementRef: ElementRef<HTMLElement>, defaults: MatAutocompleteDefaultOptions, platform?: Platform);
    ariaLabel: string;
    ariaLabelledby: string;
    get autoActiveFirstOption(): boolean;
    set autoActiveFirstOption(value: BooleanInput);
    get autoSelectActiveOption(): boolean;
    set autoSelectActiveOption(value: BooleanInput);
    set classList(value: string | string[]);
    // (undocumented)
    _classList: {
        [key: string]: boolean;
    };
    readonly closed: EventEmitter<void>;
    displayWith: ((value: any) => string) | null;
    _emitSelectEvent(option: _MatOptionBase): void;
    _getPanelAriaLabelledby(labelId: string | null): string | null;
    _getScrollTop(): number;
    protected abstract _hiddenClass: string;
    id: string;
    readonly inertGroups: boolean;
    get isOpen(): boolean;
    // (undocumented)
    _isOpen: boolean;
    _keyManager: ActiveDescendantKeyManager<_MatOptionBase>;
    // (undocumented)
    ngAfterContentInit(): void;
    // (undocumented)
    ngOnDestroy(): void;
    readonly opened: EventEmitter<void>;
    readonly optionActivated: EventEmitter<MatAutocompleteActivatedEvent>;
    abstract optionGroups: QueryList<_MatOptgroupBase>;
    abstract options: QueryList<_MatOptionBase>;
    readonly optionSelected: EventEmitter<MatAutocompleteSelectedEvent>;
    panel: ElementRef;
    panelWidth: string | number;
    _setColor(value: ThemePalette): void;
    _setScrollTop(scrollTop: number): void;
    _setVisibility(): void;
    showPanel: boolean;
    template: TemplateRef<any>;
    protected abstract _visibleClass: string;
    // (undocumented)
    static ɵdir: i0.ɵɵDirectiveDeclaration<_MatAutocompleteBase, never, never, { "ariaLabel": "aria-label"; "ariaLabelledby": "aria-labelledby"; "displayWith": "displayWith"; "autoActiveFirstOption": "autoActiveFirstOption"; "autoSelectActiveOption": "autoSelectActiveOption"; "panelWidth": "panelWidth"; "classList": "class"; }, { "optionSelected": "optionSelected"; "opened": "opened"; "closed": "closed"; "optionActivated": "optionActivated"; }, never, never, false, never>;
    // (undocumented)
    static ɵfac: i0.ɵɵFactoryDeclaration<_MatAutocompleteBase, never>;
}

// @public
export interface MatAutocompleteDefaultOptions {
    autoActiveFirstOption?: boolean;
    autoSelectActiveOption?: boolean;
    overlayPanelClass?: string | string[];
}

// @public (undocumented)
export class MatAutocompleteModule {
    // (undocumented)
    static ɵfac: i0.ɵɵFactoryDeclaration<MatAutocompleteModule, never>;
    // (undocumented)
    static ɵinj: i0.ɵɵInjectorDeclaration<MatAutocompleteModule>;
    // (undocumented)
    static ɵmod: i0.ɵɵNgModuleDeclaration<MatAutocompleteModule, [typeof i1.MatAutocomplete, typeof i2.MatAutocompleteTrigger, typeof i3.MatAutocompleteOrigin], [typeof i4.OverlayModule, typeof i5.MatOptionModule, typeof i5.MatCommonModule, typeof i6.CommonModule], [typeof i7.CdkScrollableModule, typeof i1.MatAutocomplete, typeof i5.MatOptionModule, typeof i5.MatCommonModule, typeof i2.MatAutocompleteTrigger, typeof i3.MatAutocompleteOrigin]>;
}

// @public
export class MatAutocompleteOrigin extends _MatAutocompleteOriginBase {
    // (undocumented)
    static ɵdir: i0.ɵɵDirectiveDeclaration<MatAutocompleteOrigin, "[matAutocompleteOrigin]", ["matAutocompleteOrigin"], {}, {}, never, never, false, never>;
    // (undocumented)
    static ɵfac: i0.ɵɵFactoryDeclaration<MatAutocompleteOrigin, never>;
}

// @public
export abstract class _MatAutocompleteOriginBase {
    constructor(
    elementRef: ElementRef<HTMLElement>);
    elementRef: ElementRef<HTMLElement>;
    // (undocumented)
    static ɵdir: i0.ɵɵDirectiveDeclaration<_MatAutocompleteOriginBase, never, never, {}, {}, never, never, false, never>;
    // (undocumented)
    static ɵfac: i0.ɵɵFactoryDeclaration<_MatAutocompleteOriginBase, never>;
}

// @public
export class MatAutocompleteSelectedEvent {
    constructor(
    source: _MatAutocompleteBase,
    option: _MatOptionBase);
    option: _MatOptionBase;
    source: _MatAutocompleteBase;
}

// @public (undocumented)
export class MatAutocompleteTrigger extends _MatAutocompleteTriggerBase {
    // (undocumented)
    protected _aboveClass: string;
    // (undocumented)
    static ɵdir: i0.ɵɵDirectiveDeclaration<MatAutocompleteTrigger, "input[matAutocomplete], textarea[matAutocomplete]", ["matAutocompleteTrigger"], {}, {}, never, never, false, never>;
    // (undocumented)
    static ɵfac: i0.ɵɵFactoryDeclaration<MatAutocompleteTrigger, never>;
}

// @public
export abstract class _MatAutocompleteTriggerBase implements ControlValueAccessor, AfterViewInit, OnChanges, OnDestroy {
    constructor(_element: ElementRef<HTMLInputElement>, _overlay: Overlay, _viewContainerRef: ViewContainerRef, _zone: NgZone, _changeDetectorRef: ChangeDetectorRef, scrollStrategy: any, _dir: Directionality | null, _formField: MatFormField | null, _document: any, _viewportRuler: ViewportRuler, _defaults?: MatAutocompleteDefaultOptions | null | undefined);
    protected abstract _aboveClass: string;
    get activeOption(): _MatOptionBase | null;
    autocomplete: _MatAutocompleteBase;
    autocompleteAttribute: string;
    get autocompleteDisabled(): boolean;
    set autocompleteDisabled(value: BooleanInput);
    closePanel(): void;
    connectedTo: _MatAutocompleteOriginBase;
    // (undocumented)
    _handleClick(): void;
    // (undocumented)
    _handleFocus(): void;
    // (undocumented)
    _handleInput(event: KeyboardEvent): void;
    // (undocumented)
    _handleKeydown(event: KeyboardEvent): void;
    // (undocumented)
    ngAfterViewInit(): void;
    // (undocumented)
    ngOnChanges(changes: SimpleChanges): void;
    // (undocumented)
    ngOnDestroy(): void;
    _onChange: (value: any) => void;
    _onTouched: () => void;
    openPanel(): void;
    readonly optionSelections: Observable<MatOptionSelectionChange>;
    get panelClosingActions(): Observable<MatOptionSelectionChange | null>;
    get panelOpen(): boolean;
    position: 'auto' | 'above' | 'below';
    // (undocumented)
    registerOnChange(fn: (value: any) => {}): void;
    // (undocumented)
    registerOnTouched(fn: () => {}): void;
    // (undocumented)
    setDisabledState(isDisabled: boolean): void;
    updatePosition(): void;
    // (undocumented)
    writeValue(value: any): void;
    // (undocumented)
    static ɵdir: i0.ɵɵDirectiveDeclaration<_MatAutocompleteTriggerBase, never, never, { "autocomplete": "matAutocomplete"; "position": "matAutocompletePosition"; "connectedTo": "matAutocompleteConnectedTo"; "autocompleteAttribute": "autocomplete"; "autocompleteDisabled": "matAutocompleteDisabled"; }, {}, never, never, false, never>;
    // (undocumented)
    static ɵfac: i0.ɵɵFactoryDeclaration<_MatAutocompleteTriggerBase, [null, null, null, null, null, null, { optional: true; }, { optional: true; host: true; }, { optional: true; }, null, { optional: true; }]>;
}

// (No @packageDocumentation comment for this package)

```