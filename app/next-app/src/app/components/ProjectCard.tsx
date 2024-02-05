import React from 'react'
import { Card } from 'flowbite-react'

type Props = {
    name: string,
    oragnization: string,
    description: string,
}

export default function ProjectCard({name, oragnization, description}: Props) {
  return (
    <Card href="#" className='max-w-lg my-2'>
      <h5 className='text-2xl font-bold tracking-tight text-gray-900 dark:text-white'>
        {name}
      </h5>
      <h6 className='text-md italic font-normal text-gray-600 dark:text-gray-200'>
        {oragnization}
      </h6> 
      <p className='font-normal text-gray-700 dark:text-gray-400'>
        {description}
      </p>
    </Card>
  )
}
