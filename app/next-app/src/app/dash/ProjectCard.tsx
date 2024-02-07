import React from 'react'
import { Card } from 'flowbite-react'

type Props = {
  name: string,
  org: string,
  desc: string,
  majors: string[]
}

export default function ProjectCard({name, desc, org, majors}: Props) {
  return (
    <Card href="#" className=' max-w-6xl my-2'>
      <h5 className='text-2xl font-bold tracking-tight text-gray-900 dark:text-white'>
        {name}
      </h5>
      <div className='grid grid-cols-2'>
        <p className='text-md underline font-normal text-gray-600 dark:text-gray-200'>
          {org}
        </p> 
        <div className='text-md text-right font-normal text-gray-600 dark:text-gray-200'>
        🎓 {majors.toString().replaceAll(',', ', ')} 
        </div>
      </div>
      
      <p className='font-normal text-gray-700 dark:text-gray-400 line-clamp-2'>
        {desc}
      </p>
      
    </Card>
  )
}
