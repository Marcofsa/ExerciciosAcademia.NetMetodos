## API Report File for "components-srcs"

> Do not edit this file. It is a report generated by [API Extractor](https://api-extractor.com/).

```ts

import { BaseHarnessFilters } from '@angular/cdk/testing';
import { ComponentHarness } from '@angular/cdk/testing';
import { ComponentHarnessConstructor } from '@angular/cdk/testing';
import { ContentContainerComponentHarness } from '@angular/cdk/testing';
import { DividerHarnessFilters } from '@angular/material/divider/testing';
import { HarnessPredicate } from '@angular/cdk/testing';
import { MatDividerHarness } from '@angular/material/divider/testing';
import { MatListOptionTogglePosition } from '@angular/material/list';

// @public (undocumented)
export interface ActionListHarnessFilters extends BaseHarnessFilters {
}

// @public (undocumented)
export interface ActionListItemHarnessFilters extends BaseListItemHarnessFilters {
}

// @public (undocumented)
export interface BaseListItemHarnessFilters extends BaseHarnessFilters {
    // (undocumented)
    fullText?: string | RegExp;
    // (undocumented)
    secondaryText?: string | RegExp | null;
    // (undocumented)
    tertiaryText?: string | RegExp | null;
    // @deprecated (undocumented)
    text?: string | RegExp;
    // (undocumented)
    title?: string | RegExp;
}

// @public (undocumented)
export interface ListHarnessFilters extends BaseHarnessFilters {
}

// @public (undocumented)
export interface ListItemHarnessFilters extends BaseListItemHarnessFilters {
}

// @public (undocumented)
export interface ListOptionHarnessFilters extends BaseListItemHarnessFilters {
    // (undocumented)
    selected?: boolean;
}

// @public
export class MatActionListHarness extends MatListHarnessBase<typeof MatActionListItemHarness, MatActionListItemHarness, ActionListItemHarnessFilters> {
    static hostSelector: string;
    // (undocumented)
    _itemHarness: typeof MatActionListItemHarness;
    static with<T extends MatActionListHarness>(this: ComponentHarnessConstructor<T>, options?: ActionListHarnessFilters): HarnessPredicate<T>;
}

// @public
export class MatActionListItemHarness extends MatListItemHarnessBase {
    blur(): Promise<void>;
    click(): Promise<void>;
    focus(): Promise<void>;
    static hostSelector: string;
    isFocused(): Promise<boolean>;
    static with<T extends MatActionListItemHarness>(this: ComponentHarnessConstructor<T>, options?: ActionListItemHarnessFilters): HarnessPredicate<T>;
}

// @public
export class MatListHarness extends MatListHarnessBase<typeof MatListItemHarness, MatListItemHarness, ListItemHarnessFilters> {
    static hostSelector: string;
    // (undocumented)
    _itemHarness: typeof MatListItemHarness;
    static with<T extends MatListHarness>(this: ComponentHarnessConstructor<T>, options?: ListHarnessFilters): HarnessPredicate<T>;
}

// @public
export class MatListItemHarness extends MatListItemHarnessBase {
    static hostSelector: string;
    static with<T extends MatListItemHarness>(this: ComponentHarnessConstructor<T>, options?: ListItemHarnessFilters): HarnessPredicate<T>;
}

// @public
export const enum MatListItemSection {
    // (undocumented)
    CONTENT = ".mdc-list-item__content"
}

// @public
export const enum MatListItemType {
    // (undocumented)
    ONE_LINE_ITEM = 0,
    // (undocumented)
    THREE_LINE_ITEM = 2,
    // (undocumented)
    TWO_LINE_ITEM = 1
}

// @public
export class MatListOptionHarness extends MatListItemHarnessBase {
    blur(): Promise<void>;
    deselect(): Promise<void>;
    focus(): Promise<void>;
    getCheckboxPosition(): Promise<MatListOptionTogglePosition>;
    getRadioPosition(): Promise<MatListOptionTogglePosition>;
    static hostSelector: string;
    isFocused(): Promise<boolean>;
    isSelected(): Promise<boolean>;
    select(): Promise<void>;
    toggle(): Promise<void>;
    static with<T extends MatListOptionHarness>(this: ComponentHarnessConstructor<T>, options?: ListOptionHarnessFilters): HarnessPredicate<T>;
}

// @public
export class MatNavListHarness extends MatListHarnessBase<typeof MatNavListItemHarness, MatNavListItemHarness, NavListItemHarnessFilters> {
    static hostSelector: string;
    // (undocumented)
    _itemHarness: typeof MatNavListItemHarness;
    static with<T extends MatNavListHarness>(this: ComponentHarnessConstructor<T>, options?: NavListHarnessFilters): HarnessPredicate<T>;
}

// @public
export class MatNavListItemHarness extends MatListItemHarnessBase {
    blur(): Promise<void>;
    click(): Promise<void>;
    focus(): Promise<void>;
    getHref(): Promise<string | null>;
    static hostSelector: string;
    isActivated(): Promise<boolean>;
    isFocused(): Promise<boolean>;
    static with<T extends MatNavListItemHarness>(this: ComponentHarnessConstructor<T>, options?: NavListItemHarnessFilters): HarnessPredicate<T>;
}

// @public
export class MatSelectionListHarness extends MatListHarnessBase<typeof MatListOptionHarness, MatListOptionHarness, ListOptionHarnessFilters> {
    deselectItems(...filters: ListItemHarnessFilters[]): Promise<void>;
    static hostSelector: string;
    isDisabled(): Promise<boolean>;
    // (undocumented)
    _itemHarness: typeof MatListOptionHarness;
    selectItems(...filters: ListOptionHarnessFilters[]): Promise<void>;
    static with<T extends MatSelectionListHarness>(this: ComponentHarnessConstructor<T>, options?: SelectionListHarnessFilters): HarnessPredicate<T>;
}

// @public
export class MatSubheaderHarness extends ComponentHarness {
    getText(): Promise<string>;
    // (undocumented)
    static hostSelector: string;
    // (undocumented)
    static with(options?: SubheaderHarnessFilters): HarnessPredicate<MatSubheaderHarness>;
}

// @public (undocumented)
export interface NavListHarnessFilters extends BaseHarnessFilters {
}

// @public (undocumented)
export interface NavListItemHarnessFilters extends BaseListItemHarnessFilters {
    // (undocumented)
    activated?: boolean;
    // (undocumented)
    href?: string | RegExp | null;
}

// @public (undocumented)
export interface SelectionListHarnessFilters extends BaseHarnessFilters {
}

// @public (undocumented)
export interface SubheaderHarnessFilters extends BaseHarnessFilters {
    // (undocumented)
    text?: string | RegExp;
}

// (No @packageDocumentation comment for this package)

```