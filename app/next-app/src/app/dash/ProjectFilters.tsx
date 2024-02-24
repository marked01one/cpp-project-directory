import { Card } from 'flowbite-react'
import React from 'react'
import FilterMajor from './filters/FilterMajor'

export default function ProjectFilters() {
  return (
    <Card className='my-2'>
      <h5 className='text-xl font-bold text-gray-900 dark:text-gray-100'>Filter & Sort</h5>
      <p className='dark:text-gray-100'>Placeholder text lol</p>
      <FilterMajor />
    </Card>
  )
}
