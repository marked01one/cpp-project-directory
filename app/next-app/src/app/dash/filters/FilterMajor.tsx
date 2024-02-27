'use client'

import React from 'react'
import { Checkbox, Label } from 'flowbite-react'

export default function FilterMajor() {
  return (
    <div className="flex max-w-md flex-col gap-4 px-4 pb-6 pt-2" id="checkbox">
      <div className="flex align-middle gap-2">
        <Checkbox id="cs" />
        <Label className='dark:text-gray-300'>
          Computer Science
        </Label>
      </div>
      <div className="flex align-middle gap-2">
        <Checkbox id="cpe" />
        <Label className='rounded dark:text-gray-300'>
          Computer Engineering
        </Label>
      </div>
      <div className="flex align-middle gap-2">
        <Checkbox id="age" />
        <Label className='dark:text-gray-300'>
          Electrical Engineering
        </Label>
      </div>
      <div className="flex align-middle gap-2">
        <Checkbox id="shipping" />
        <Label className='dark:text-gray-300'>
          Mechanical Engineering
        </Label>
      </div>
      <div className="flex align-middle gap-2">
        <Checkbox id="shipping" />
        <Label className='dark:text-gray-300'>
          Aerospace Engineering
        </Label>
      </div>
    </div>
  );
}